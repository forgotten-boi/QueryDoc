(function ($) {
    $('#ProgramLastDate').datetimepicker({ mask: true, timepicker: false, format: 'Y/m/d', minDate: "1" });

    $(function () {

        var _$form = $('#ProgramUpdationForm');

        _$form.find('input:first').focus();

        _$form.validate();

        _$form.find('button[type=submit]')
            .click(function (e) {
                e.preventDefault();

                if (!_$form.valid()) {
                    return;
                }

                var input = _$form.serializeFormToObject();
                abp.services.app.eClass.update(input)
                    .done(function () {
                        location.href = '/EClass';
                    });
            });
    });
})(jQuery);