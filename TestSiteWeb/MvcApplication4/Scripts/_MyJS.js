$(document).ready( function()
{
    $("#FirstName").autocomplete({
        source: function (request, response) {
            var customer = new Array();
            $.ajax({
                async: false,
                cache: false,
                type: "POST",
                url: "/Personne/Autocomplete",
                data: { "term": request.term },
                success: function (data) {
                    alert(data.length)

                for (var i = 0; i < data.length ; i++) {
                    customer[i] = { label: data[i].FirstName + " " + data[i].LastName, value: data[i].FirstName, Id: data[i].id };
                }
            }
        });
    response(customer);
},
    select: function (event, ui) {
        //fill selected customer details on form
    //      $.ajax({
    //        cache: false,
    //        async: false,
    //        type: "POST",
    //        url: "@(Url.Action("GetDetail", " Home"))",
    //        data: { "id": ui.item.Id },

    //    success: function (data) {
    //        $('#VisitorDetail').show();
    //        $("#Name").html(data.VisitorName)
    //        $("#PatientName").html(data.PatientName)
    //        //alert(data.ArrivingTime.Hours)
    //        $("#VisitorId").val(data.VisitorId)
    //        $("#Date").html(data.Date)
    //        $("#ArrivingTime").html(data.ArrivingTime)
    //        $("#OverTime").html(data.OverTime)

    //        action = data.Action;
    //    },
    //    error: function (xhr, ajaxOptions, thrownError) {
    //        alert('Failed to retrieve states.');
    //    }
    //});
    }
    }); 
});