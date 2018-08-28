(function ($) {
    $(function () {

        var _$form = $('#CategoryListForm');

        _$form.find('a[name=DeleteCategory]')
            .click(function (e) {
                e.preventDefault();

                var categoryId = $(this).data("index");
                abp.services.app.eClass.deleteCategory(categoryId)
                    .done(function () {
                        location.href = '/EClass/CategoryList';
                    });
            });
    });
})(jQuery);