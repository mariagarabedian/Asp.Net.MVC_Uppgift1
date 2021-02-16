
$('#firstname, #lastname, #email, #password, #password1').bind('keyup', function () {
	if (allFilled()) $('#button').removeAttr('disabled');

});

function allFilled() {
	var filled = true;
	$('body input').each(function () {
		if ($(this).val() == '') filled = false;
		else { $('#button').prop("disabled", true) }
	});
	return filled;

}

