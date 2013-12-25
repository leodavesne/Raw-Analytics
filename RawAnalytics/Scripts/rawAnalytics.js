function TagEvent(label, value)
{
	var url = "/Insert";

	var data = {
		"Label": label,
		"Value": value
	};

	var dataType = "json";

	$.ajax({
		type: "POST",
		url: url,
		data: data,
		dataType: dataType
	});

	// TODO: forcer minuscules sur le label et la valeur ?
}
