$(document).ready(function () {
    $('.deleteButton').on('click', function (e) {
        let $target = $(e.target);
        let id = $target.data('appointment-id');
        if (confirm('Are you sure you want to delete this appointment? ')) {
            $.post(Router.action("Appointment", "DeleteAppointment", { id: id }))
                .done(manageResult) 
                .fail(function () {
                    alert("an error has occured!");
                });
        }
    });
    function manageResult(result) {
        if (result === 'Error') {
            alert('Va rugam sa stergeti intai piesele de masina asociate programarii');
        }
        else {
            location.reload();
        }
    }

});