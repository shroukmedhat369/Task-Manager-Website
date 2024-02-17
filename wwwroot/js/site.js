// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification

function validate() {
    var returnValue = true;
    var username = frmRegister.UserName.value;
    var password1 = frmRegister.Password.value;
  
    if (username.length < 6) {
        returnValue = false;
        alert("Your username must be at least\n6 characters long.\nPlease try again.");
        frmRegister.UserName.focus();
    }
    if (password1.length < 6) {
        returnValue = false;
        alert("Your password must be at least\n6 characters long.\nPlease try again.");
        frmRegister.Password.value = "";
        frmRegister.Password.focus();
    }

    if (returnValue) {
        frmRegister.submit();
    }

    return returnValue;
}

function redirectToAnotherAction() {
 
    window.location.href = 'Register/Index';
}
