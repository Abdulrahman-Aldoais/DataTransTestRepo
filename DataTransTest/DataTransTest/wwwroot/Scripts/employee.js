/// <reference path="jquery-1.9.1.intellisense.js" />
//Load Data in Table when documents is ready
$(document).ready(function () {
    getEmployeeData();
});



function getEmployeeData() {
    $.ajax({
        type: "GET",
        url: "/Home/GetAllUser",
        data: {},
        success: function (data) {
            for (var i = 0; i < data.getInfo.length; i++) {
                $("#tblBody").append("<tr>" +
                    "<td>" + data.getInfo[i].id + "</td>" +  // Change here
                    "<td>" + data.getInfo[i].firstName + "</td>" +
                    "<td>" + data.getInfo[i].lastName + "</td>" +
                    "<td>" + data.getInfo[i].phone + "</td>" +
                    "<td>" + data.getInfo[i].address + "</td>" +
                    "<td>" + data.getInfo[i].email + "</td>" +
                    "<td>" +
                    /*"<a href='/Home/Edit/" + data.getInfo[i].id + "' class='btn btn-success'>تـعديل</a>" +*/
                    ///*  "<a href='#' data-userid='" + data.getInfo[i].id + "' class='btn btn-success edit-btn'>Edit2</a>"+*/
                //"<a href='/Home/Delete/" + data.getInfo[i].id + "' class='btn btn-danger'> حـذف </a>" +
                "<a href='/Home/Edit/" + data.getInfo[i].id + "' class='btn btn-success'>تـعديل</a>"+
                ///*  "<a href='#' data-userid='" + data.getInfo[i].id + "' class='btn btn-success edit-btn'>Edit2</a>"+*/
                    "<a href='#' onclick='Delele(" + data.getInfo[i].id + ")' class='btn btn-danger'> حـذف </a>" +
                    //"<a href='#' onclick='return getbyID(" + data.getInfo[i].id + ")'class='btn btn-success edit-btn'>Edit</a> | <a href='#' onclick='Delele(" + data.getInfo[i].id + ")'class='btn btn-danger'>Delete</a>"+
                    "</td>" +
                    "</tr>");
            }

        },

        error: function (er) {
            alert(er)
        }
    });
}



function Add() {
    var res = validate();
    if (!res) {
        return false;
    }

    var empObj = {
        FirstName: $('#FirstName').val(),
        LastName: $('#LastName').val(),
        Phone: $('#Phone').val(),
        Address: $('#Address').val(),
        Email: $('#Email').val()
    };

    $.ajax({
        url: "/Home/AddAjax",
        data: empObj,
        type: "POST",
        success: function (result) {
            if (result.success) {
                $('#myModal').modal('hide');
                // إذا كنت تريد توجيه المستخدم إلى صفحة مختلفة بعد الإضافة
                window.location.href = "/Home/Index";
            } else {
                alert("Error: " + result.errors.join("\n"));
            }
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}



//Function for clearing the textboxes
function clearTextBox() {
    $('#Id').val("");
    $('#FirstName').val("");
    $('#LastName').val("");
    $('#Phone').val("");
    $('#Address').val("");
    $('#Email').val("");
    $('#btnUpdate').hide();
    $('#btnAdd').show();
    $('#Id').prop('disabled', false);  // Enable the Id field
    $('#FirstName').css('border-color', 'lightgrey');
    $('#LastName').css('border-color', 'lightgrey');
    $('#Phone').css('border-color', 'lightgrey');
    $('#Address').css('border-color', 'lightgrey');
    $('#Email').css('border-color', 'lightgrey');
}

//Valdidation using jquery


function validate() {
    var fieldsToValidate = ["FirstName", "LastName", "Phone", "Address", "Email"];
    var isValid = true;

    for (var i = 0; i < fieldsToValidate.length; i++) {
        var fieldId = "#" + fieldsToValidate[i];
        var fieldValue = $(fieldId).val().trim();

        console.log(fieldsToValidate[i] + ": " + fieldValue);

        if (fieldValue === "") {
            // If the field is empty, set border color to red and set isValid to false
            $(fieldId).css('border-color', 'Red');
            isValid = false;
        } else {
            // If the field is not empty, set border color to lightgrey
            $(fieldId).css('border-color', 'lightgrey');
        }
    }

    return isValid;
}



//Function for getting the Data Based upon Employee ID
//function getbyID(id) {
//    $('#FirstName').css('border-color', 'lightgrey');
//    $('#LastName').css('border-color', 'lightgrey');
//    $('#Phone').css('border-color', 'lightgrey');
//    $('#Address').css('border-color', 'lightgrey');
//    $('#Email').css('border-color', 'lightgrey');
//    $.ajax({
//        url: "/Home/GetbyID/" + id,  // تحديث اسم العملية إلى GetbyID
//        type: "GET",
//        contentType: "application/json;charset=UTF-8",
//        dataType: "json",
//        success: function (result) {
//            $('#Id').val(result.Id);  // تحديث اسم الخاصية من EmployeeID إلى Id
//            $('#FirstName').val(result.FirstName);
//            $('#LastName').val(result.LastName);
//            $('#Phone').val(result.Phone);
//            $('#Address').val(result.Address);
//            $('#Email').val(result.Email);

//            $('#myModal').modal('show');
//            $('#btnUpdate').show();
//            $('#btnAdd').hide();
//        },
//        error: function (errormessage) {
//            alert(errormessage.responseText);
//        }
//    });
//    return false;
//}


//function for updating employee's record
//function Update() {
//    var res = validate();
//    if (res == false) {
//        return false;
//    }
//    var empObj = {
//        Id: $('#Id').val(),
//        FirstName: $('#FirstName').val(),
//        LastName: $('#LastName').val(),
//        Phone: $('#Phone').val(),
//        Address: $('#Address').val(),
//        Email: $('#Email').val(),
//    };
//    $.ajax({
//        url: "/Home/Update",
//        data: JSON.stringify(empObj),
//        type: "POST",
//        contentType: "application/json;charset=utf-8",
//        dataType: "json",
//        success: function (result) {
//            loadData();
//            $('#myModal').modal('hide');
//            $('#Id').val("");
//            $('#FirstName').val("");
//            $('#LastName').val("");
//            $('#Phone').val("");
//            $('#Address').val("");
//            $('#Email').val("");
//        },
//        error: function (errormessage) {
//            alert(errormessage.responseText);
//        }
//    });
//}

//function for deleting employee's record
function Delele(ID) {
    var ans = confirm("هل انت متــاكد من الحــــذف");
    if (ans) {
        $.ajax({
            url: "/Home/Delete/" + ID,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                // إعادة توجيه إلى الصفحة الخاصة بالجدول بعد نجاح الحذف
                window.location.href = "/Home/Index";
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}



