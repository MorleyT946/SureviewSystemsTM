
$(document).ready(function () {
    $("#frmAlarmMessage").validate({
        rules: {
            Message: {
                required: true,
                minlength: 5
            }
        },
        submitHandler: function (form) {
            form.submit();
        }
    });
});