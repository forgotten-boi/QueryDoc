(function ($) {
    $(function () {

        var _$form = $('#CategoryUpdateForm');

        _$form.find('input:first').focus();

        _$form.validate();

        _$form.find('button[type=submit]')
            .click(function (e) {
                e.preventDefault();

                if (!_$form.valid()) {
                    return;
                }

                var input = _$form.serializeFormToObject();
                abp.services.app.eClass.updateCategory(input)
                    .done(function () {
                        location.href = '/EClass/CategoryList';
                    });
            });
    });
})(jQuery);