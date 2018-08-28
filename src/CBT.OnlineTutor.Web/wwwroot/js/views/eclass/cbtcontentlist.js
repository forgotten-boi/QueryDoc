(function ($) {
    $(function () {

        var _$form = $('#CBTContentListForm');

        _$form.find('a[name=DeleteCBTContent]')
            .click(function (e) {
                e.preventDefault();

                var cbtContentId = $(this).data("index");
               // abp.message.confirm(
                    //app.localize('AreYouSureToDelete'),
                    //function (isConfirmed) {
                    //    if (isConfirmed) {
                            abp.services.app.eClass.deleteCBTContent(cbtContentId)
                                .done(function () {
                                    location.href = '/EClass/CBTContentList';
                                });
                    //    }
                    //});
            });
    });
})(jQuery);