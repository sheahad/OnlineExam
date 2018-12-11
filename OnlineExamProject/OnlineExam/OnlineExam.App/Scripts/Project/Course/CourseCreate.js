


var validate = true;

$("#Name").change(function () {
    var name = $(this).val();

    var url = "../../Course/IsNameExist";
    var params = { name: name };
    $.post(url, params, function (rData) {
        if (rData === true) {
            alert("Name Already Exist");
            validate = false;
            return false;
        }
        validate = true;
    });
});



//$("#DepartmentId").change(function () {

//    //var departmentId = $("#DepartmentId").val();
//    var departmentId = $(this).val();
//    if (departmentId == "2") {
//        $("#Address").val("");
//        $("#AddressDiv").hide();
//    } else {
//        $("#AddressDiv").show();
//    }

//    if (departmentId == "1") {
//        var textArea = "<textarea class='form-control' id='Description' name='Description'></textarea>";
//        $("#DescriptionDiv").html(textArea);
//    } else {
//        $("#DescriptionDiv").html("");
//    }





    //var params = { departmentId: departmentId }
    //$.ajax({
    //    type: "POST",
    //    url: "../../Employee/GetEmployeesByDepartmentId",
    //    contentType: "application/json; charset=utf-8",
    //    data: JSON.stringify(params),
    //    success: function (response) {
    //        if (response != undefined && response != null && response != "") {
    //            $("#EmployeeId").empty();
    //            $("#EmployeeId").append('<option>---Select---</option>');
    //            $.each(response, function (k, v) {

    //                $("#EmployeeId").append("<option value='" + v.Id + "'>" + v.Name + "</option>");

    //            });
    //        }
    //    }


    //});


//});


//$(document.body).on("change", "#EmployeeId", function () {

//    var employeeId = $(this).val();
//    var url = "../../Employee/GetEducationByEmployeeId";
//    var params = { employeeId: employeeId };
//    $.post(url, params, function (rData) {
//        if (rData != undefined && rData != null && rData != "") {
//            $("#EmployeeEducationId").empty();
//            $("#EmployeeEducationId").append('<option>---Select---</option>');
//            $.each(rData, function (k, v) {

//                $("#EmployeeEducationId").append("<option value='" + v.Id + "'>" + v.Name + "</option>");

//            });
//        }
//    }), fail(function (failedMsg) {
//        alert(failedMsg);
//    });

//});



//var isMale = true;

$("#SubmitButton").click(function () {
    if (!validate) {
        return false;
    }

    if (isCodeValid()) {
        return true;
    }
    return false;
});


function isCodeValid() {

   
        var Code = $("#Code").val();
        if (Code !== undefined && Code !== "") {
            $("#CourseValidationLebel").text("");
            return true;
        }
    
    $("#CourseValidationLebel").text("Field Is Required");
    return false;
}



$("#FirstTextBox").keyup(function () {
    var value = $(this).val();
    $("#SecondTextBox").val(value);
})