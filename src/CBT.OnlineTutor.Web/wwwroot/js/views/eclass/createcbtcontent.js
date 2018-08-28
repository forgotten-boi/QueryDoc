﻿(function ($) {
    $(function () {
        $('#Description').ckeditor();
    });

    //DEFAULT DIV HIDE ON PAGE LOAD
    $('#main').hide();

    $('#CategoryCombobox').change(function () {
        var url = '/EClass/GetCBTContentByCategoryId';
        var ddlsource = "#CategoryCombobox";
        $.getJSON(url, { CategoryID: $(ddlsource).val() }, function (data) {
            var items = '';
            $("#PrecedingCBTContentId").empty();
            for (var i = 0; i < data.result.length; i++) {
                items += "<option value='" + data.result[i].value + "'>" + data.result[i].text + "</option>";
            }
            $('#PrecedingCBTContentId').html(items);
        });
    });

    //START-SHOW HIDE DIV BASED ON CONTENT TYPE DROPDOWN SELECTION
    $('#ContentTypeCombobox').change(function () {
        var value = $(this).val();

        if (value == '') {
            $('#main').hide();
        }
        else {
            $('#main').show();
            if (value == '1') {
                $('#optionNumeric').show();
                $('#optionMultipleChoice').hide();
            } else {
                $('#optionNumeric').hide();
            }

            if (value == '2') {
                $('#multipleTextBox').show();
            }
            else {
                $('#multipleTextBox').hide();
            }

            if (value == '3') {
                //$('#optionNumeric').hide();
                $('#optionMultipleChoice').show();
                $('#multipleChoice').show();
            } else {
                $('#optionMultipleChoice').hide();
                $('#multipleChoice').hide();
            }

            if (value == '4') {
                $('#dropDown').show();
            }
            else {
                $('#dropDown').hide();
            }

            if (value == '5' || value == '6' || value == '7' || value == '8') {
                $('#fileUpload').show();

                if (value == '5') {
                    $('#docType').html("(ONLY MP4 TYPE VIDEO SUPPORTED)");
                }
                else if (value == '6') {
                    $('#docType').html("(ONLY MP3 TYPE AUDIO SUPPORTED)");
                }
                else if (value == '7') {
                    $('#docType').html("(ONLY JPG/JPEG/BMP/GIF/PNG TYPE IMAGE SUPPORTED)");
                }
                else if (value == '8') {
                    $('#docType').html("(ONLY MP4 TYPE FLASH SUPPORTED)");
                }
                else {
                    $('#docType').html("(ONLY JPG/JPEG/BMP/GIF/PNG TYPE IMAGE SUPPORTED)");
                }
            }
            else {
                $('#fileUpload').hide();
            }
        }
    });
    //END-SHOW HIDE DIV BASED ON CONTENT TYPE DROPDOWN SELECTION

    //START-DYNAMIC MULTIPLE TEXT ADD/REMOVE SECTION
    var multiTextClone = (function () {
        var multiTextCloneIndex = 0;
        var multiTextTemplate = $('#mtTemplate').text();
        return function () {
            //Replace all instances of {{ID}} in our template with the cloneIndex.
            return multiTextTemplate.replace(/{{ID}}/g, ++multiTextCloneIndex);
        }
    })();//self executing function.

    var cloneMultiText = $('#cloneMultiTextbox')

    $(document).on("click", 'a.addMT', function () {
        cloneMultiText.append(multiTextClone());
        ResetMTIndex();
        var count = $(".multiTextbox").length;
        $('#hdnDynamicRow').val(count);
    });

    //Start us off with 1 category.
    cloneMultiText.append(multiTextClone());

    $(document).on("click", 'a.deleteMT', function () {
        var multiTextCloneIndex = $(".multiTextbox").length;
        if (multiTextCloneIndex != 1) {
            $(this).parents(".multiTextbox").remove();
        }
        ResetMTIndex();
    });

    function ResetMTIndex() {
        var cnt = 0;
        $(".multiTextbox").each(function () {
            cnt++;
            $(this).find('.lblOption').html("Label " + cnt);
            $(this).find('.txtMultipleText').attr('name', "txtMultipleText_" + cnt);
            $(this).find('.txtMultipleText').attr('id', "txtMultipleText_" + cnt);
            $(this).find('.ddlMultipleDataType').attr('name', "ddlMultipleDataType_" + cnt);
            $(this).find('.ddlMultipleDataType').attr('id', "ddlMultipleDataType_" + cnt);
        });
    }
    //END-DYNAMIC MULTIPLE TEXT SECTION

    //START-DYNAMIC MULTIPLE CHOICE ADD/REMOVE SECTION
    var multiChoiceClone = (function () {
        var multiChoiceCloneIndex = 0;
        var multiChoiceTemplate = $('#mcTemplate').text();
        return function () {
            //Replace all instances of {{ID}} in our template with the cloneIndex.
            return multiChoiceTemplate.replace(/{{ID}}/g, ++multiChoiceCloneIndex);
        }
    })();//self executing function.

    var cloneMultiChoice = $('#cloneMultiChoice')

    $(document).on("click", 'a.addMC', function () {
        cloneMultiChoice.append(multiChoiceClone());
        ResetMCIndex();
        var count = $(".multiChoice").length;
        $('#hdnDynamicRow').val(count);
    });

    //Start us off with 1 category.
    cloneMultiChoice.append(multiChoiceClone());

    $(document).on("click", 'a.deleteMC', function () {
        var multiChoiceCloneIndex = $(".multiChoice").length;
        if (multiChoiceCloneIndex != 1) {
            $(this).parents(".multiChoice").remove();
        }
        ResetMCIndex();
    });

    function ResetMCIndex() {
        var cnt = 0;
        $(".multiChoice").each(function () {
            cnt++;
            $(this).find('.lblOption').html("Choice " + cnt);
            $(this).find('.txtMultipleOption').attr('name', "txtMultipleOption_" + cnt);
            $(this).find('.txtMultipleOption').attr('id', "txtMultipleOption_" + cnt);
        });
    }
    //END-DYNAMIC MULTIPLE CHOICE SECTION

    //START-DYNAMIC DROPDOWN ADD/REMOVE SECTION
    var dropdownClone = (function () {
        var dropdownCloneIndex = 0;
        var dropdownTemplate = $('#ddTemplate').text();
        return function () {
            //Replace all instances of {{ID}} in our template with the cloneIndex.
            return dropdownTemplate.replace(/{{ID}}/g, ++dropdownCloneIndex);
        }
    })();//self executing function.

    var cloneDropdown = $('#cloneDropdownbox')

    $(document).on("click", 'a.addDD', function () {
        cloneDropdown.append(dropdownClone());
        ResetDDIndex();
        var count = $(".dropDown").length;
        $('#hdnDynamicRow').val(count);
    });

    //Start us off with 1 category.
    cloneDropdown.append(dropdownClone());

    $(document).on("click", 'a.deleteDD', function () {
        var dropdownCloneIndex = $(".dropDown").length;
        if (dropdownCloneIndex != 1) {
            $(this).parents(".dropDown").remove();
        }
        ResetDDIndex();
    });

    function ResetDDIndex() {
        var cnt = 0;
        $(".dropDown").each(function () {
            cnt++;
            $(this).find('.lblOption').html("Dropdown Choice " + cnt);
            $(this).find('.txtDropDownOption').attr('name', "txtDropDownOption_" + cnt);
            $(this).find('.txtDropDownOption').attr('id', "txtDropDownOption_" + cnt);
        });
    }
    //END-DYNAMIC DROPDOWN ADD/REMOVE SECTION

    //START-- FILE UPLOAD SECTION.
    $("input[type=file]").change(function () {
        var uploadFile = new FormData();
        for (var i = 0; i < this.files.length; i++) {
            uploadFile.append(this.files[i].name, this.files[i]);
        }  

        $.ajax({
            url: '/EClass/UploadDocument',
            type: "POST",
            contentType: false, // Not to set any content header  
            processData: false, // Not to process data  
            data: uploadFile,
            success: function (response) {
                $('#hdnFilePath').val(response.result.filePath);
                $('#hdnFileName').val(response.result.fileName);
            },
            error: function (err) {
                alert(err.statusText);
            }
        });  
    });
    //END-- FILE UPLOAD SECTION.

    //START-DATA SAVE SECTION
    $(function () {
        
        var _$form = $('#CBTContentCreationForm');

        _$form.find('input:first').focus();

        _$form.validate();

        _$form.find('button[type=submit]')
            .click(function (e) {
                e.preventDefault();

                if (!_$form.valid()) {
                    return;
                }

                var CategoryId = $('#CategoryCombobox').val();
                var PrecedingCBTContentId = $('#PrecedingCBTContentId').val();
                var ContentTypeId = $('#ContentTypeCombobox').val();
                var Required = $('#Required').prop('checked');
                var OnlyNumericValue = $('#OnlyNumericValue').prop('checked');
                var IncludeComment = $('#IncludeComment').prop('checked');
                var AllowMultipleChoice = $('#AllowMultipleChoice').prop('checked');
                var Description = $('#Description').val();
                var Code = $('#Code').val();
                var Location = $('#hdnFilePath').val();
                var FileName = $('#hdnFileName').val();

                var cnt = 0;
                var CBTContentOption = [];

                if (ContentTypeId == 2) {
                    $(".multiTextbox").each(function () {
                        cnt++;
                        var optionValue = $(this).find('.txtMultipleText').attr('id', "txtMultipleText_" + cnt).val();
                        var dataType = $(this).find('.ddlMultipleDataType').attr('id', "ddlMultipleDataType_" + cnt).val();
                        CBTContentOption.push(optionValue, dataType);
                    });
                }
                else if (ContentTypeId == 3) {
                    $(".multiChoice").each(function () {
                        cnt++;
                        var optionValue = $(this).find('.txtMultipleOption').attr('id', "txtMultipleOption_" + cnt).val();
                        var dataType = 'VARCHAR';
                        CBTContentOption.push(optionValue, dataType);
                    });
                }
                else if (ContentTypeId == 4) {
                    $(".dropDown").each(function () {
                        cnt++;
                        var optionValue = $(this).find('.txtDropDownOption').attr('id', "txtDropDownOption_" + cnt).val();
                        var dataType = 'VARCHAR';
                        CBTContentOption.push(optionValue, dataType);
                    });
                }
                else if (ContentTypeId == 5 || ContentTypeId == 6 || ContentTypeId == 7 || ContentTypeId == 8) {
                }

                var param = {
                    'PrecedingCBTContentId': PrecedingCBTContentId, 'Code': Code, 'Description': Description, 'Required': Required, 'OnlyNumericValue': OnlyNumericValue,
                    'IncludeComment': IncludeComment, 'AllowMultipleChoice': AllowMultipleChoice,
                    'CategoryId': CategoryId, 'ContentTypeId': ContentTypeId, 'CBTContentOption': CBTContentOption, 'FileName': FileName, 'Location': Location
                };
                
                //var input = _$form.serializeFormToObject();
                //console.log(input);
                abp.services.app.eClass.createCBTContent(JSON.stringify(param))
                    .done(function () {
                        location.href = '/EClass/CBTContentList';
                    });
            });
    });
     //END-DATA SAVE SECTION
})(jQuery);