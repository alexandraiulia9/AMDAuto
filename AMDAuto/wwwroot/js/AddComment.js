$(document).ready(function () {
    $('.commentSection').hide();
    $('.commentButton').on('click', function (e) {
        let $target = $(e.target);
        let reviewId = $target.data('review-id');
        $(`div[data-review-id=${reviewId}]:eq(0)`).slideToggle("slow");
    })

    $('.addCommentButton').on('click', function (e) {
        let $target = $(e.target);
        let reviewId = $target.data('review-id');
        let comment = $(`textarea[data-review-id=${reviewId}]:eq(0)`).val();
        alert(comment);
        if (reviewId != null) {
            if (confirm('Are you sure you wnat to add a comment to this review?')) {
                $.post(Router.action("Review", "AddCommentToReview", { id: reviewId, content: comment }))
                    .done(function () {
                        location.reload();
                    })
                    .fail(function () {
                        alert("An error has occured!");
                    });
            }
        }
    })
})