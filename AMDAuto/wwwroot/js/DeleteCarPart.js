$(document).ready(function () {
    $('.deleteButton').on('click', function (e) {
        let $target = $(e.target);
        let id = $target.data('carpart-id');
    });
});