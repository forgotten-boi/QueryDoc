(function ($) {
    $("#ProgramListCombobox").on("change", function () {
        var value = $(this).val();
        $.ajax(
            {
                url: '/Preview/GetContentDetail?programId=' + value,
                type: 'GET',
                data: "",
                contentType: 'application/json; charset=utf-8',
                success: function (data) {
                    $("#partialDiv").html(data);
                },
                error: function () {
                    alert("error");
                }
            });
    });  
})(jQuery);