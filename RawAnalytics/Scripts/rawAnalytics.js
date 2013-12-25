function TagEvent(label, value)
{
	var url = "api/Tags/Insert";

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
}
