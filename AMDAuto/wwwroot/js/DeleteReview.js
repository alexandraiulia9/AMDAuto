$(document).ready(function () {
    $('.deleteReview').on('click', function (e) {
        let $target = $(e.target);
        let id = $target.data('review-id');
        if (confirm('Are you sure you want to delete this review? ')) {
            $.post(Router.action("Review", "DeleteReview", { id: id }))
                .done(function () {
                    location.reload();
                })
                .fail(function () {
                    alert("an error has occured!");
                });
        }
    });
});