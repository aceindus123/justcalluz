
 
function numbersonly(txtbox) {
    $(txtbox).keydown(function (e) {
        if ($.inArray(e.keyCode, [46, 8, 9, 27, 13, 110, 190]) !== -1 ||
        // Allow: Ctrl+A
            (e.keyCode == 65 && e.ctrlKey === true) ||
        // Allow: home, end, left, right
            (e.keyCode >= 35 && e.keyCode <= 39)) {
            // let it happen, don't do anything
            return;
        }
        // Ensure that it is a number and stop the keypress
        if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
            e.preventDefault();
        }
    });
}


function emailformat(txtbox) {
    $(txtbox).focusout(function () {
        var EmailText = $(txtbox).val();
        if ($.trim(EmailText).length == 0) {
            alert("Please enter email address");
            return false;
        }
        if (validateEmail(EmailText)) {
            return true;
        }
        else {
            alert('Invalid Email Address');
            return false;
        }
    });
}

function validateEmail(sEmail) {
    var filter = /^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
    if (filter.test(sEmail)) {
        return true;
    }
    else {
        return false;
    }
}


function storetext(cntl, pagename, method) {
    var id = document.getElementById(cntl);
    $.ajax({
        type: "POST",
        url: pagename + "/" + method,
        data: '{prefixText: "' + id.value + '" }',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
        },
        failure: function (response) {
        }
    });
}