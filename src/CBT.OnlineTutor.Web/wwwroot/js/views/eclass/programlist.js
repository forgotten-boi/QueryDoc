(function ($) {
    $(function () {

        var _$form = $('#ProgramListForm');

        //var $link = $('#DeleteProgram');
        //var href = $link.attr('href').split('/');

        _$form.find('a[name=DeleteProgram]')
            .click(function (e) {
                e.preventDefault();

                var programId = $(this).data("index"); 

               // var input = _$form.serializeFormToObject();
                abp.services.app.eClass.delete(programId)
                    .done(function () {
                        location.href = '/EClass';
                    });
            });
    });
})(jQuery);