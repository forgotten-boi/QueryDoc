(function ($) {
    var d = new Date(),
        date = (d.getUTCFullYear()) + '/' + (d.getUTCMonth() + 1) + '/' + (d.getUTCDate());
    $('#ProgramLastDate').datetimepicker({ mask: true, timepicker: false, format: 'Y/m/d', value: date, minDate: "1" });

    $(function () {

        var _$form = $('#ProgramCreationForm');

        _$form.find('input:first').focus();

        _$form.validate();

        _$form.find('button[type=submit]')
            .click(function (e) {
                e.preventDefault();

                if (!_$form.valid()) {
                    return;
                }

                var input = _$form.serializeFormToObject();
                abp.services.app.eClass.create(input)
                    .done(function () {
                        location.href = '/EClass';
                    });
            });
    });
})(jQuery);