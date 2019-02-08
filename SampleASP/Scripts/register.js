document.addEventListener("DOMContentLoaded", function () {
    // Handler when the DOM is fully loaded

    // calculate the valid age (18 years)
    var currentDate = new Date();
    var validAge = currentDate;
    validAge.setFullYear(currentDate.getFullYear() - 18);

    // intialize the datetimepicker
    $('#DateOfBirth').datetimepicker({
        format: 'L',
        maxDate: validAge,
        date: currentDOB
    });

    // logic to hide and unhide the html elements according to account type
    accountTypeSelectEl = document.getElementById("AccountType");
    enableOrDisableCompanyFields();
    accountTypeSelectEl.addEventListener("change", enableOrDisableCompanyFields);

    function enableOrDisableCompanyFields() {
        if (accountTypeSelectEl.options[accountTypeSelectEl.selectedIndex].value == "Business") {
            document.getElementById("FirstNameGroup").style.display = 'none';
            document.getElementById("LastNameGroup").style.display = 'none';
            document.getElementById("CompanyNameGroup").style.display = '';
        }
        else {
            document.getElementById("FirstNameGroup").style.display = '';
            document.getElementById("LastNameGroup").style.display = '';
            document.getElementById("CompanyNameGroup").style.display = 'none';
        }
    }
});