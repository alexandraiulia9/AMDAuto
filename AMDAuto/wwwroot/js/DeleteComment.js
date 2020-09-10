$(document).ready(function () {
    $('.deleteCommentFromReview').on('click', function (e) {
        let $target = $(e.target);
        let id = $target.data('comment-id');
        console.log(id);
        if (confirm('Sigur doriti sa stergeti comentariul?')) {
            $.post(Router.action("Comment", "DeleteComment", { id: id }))
                .done(function () {
                    location.reload();
                })
                .fail(function () {
                    alert("Eroare!");
                });
        }
    });
});