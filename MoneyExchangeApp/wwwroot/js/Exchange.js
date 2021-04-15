function getAmount() {

    let select = document.getElementById("fromCurency").children;
    let fromCurency;
    for (var i = 0; i < select.length; i++) {
        if (select[i].selected == true) {
            fromCurency = select[i].innerHTML;
        }
    }

    select = document.getElementById("toCurency").children;
    let toCurency;
    for (var i = 0; i < select.length; i++) {
        if (select[i].selected == true) {
            toCurency = select[i].innerHTML;
        }
    }

    let fromAmount = document.getElementById("fromAmount").value;

    console.log(fromCurency);
    console.log(toCurency);
    console.log(fromAmount);

    $.ajax({
        type: "POST",
        url: "/Home/GetAmount",
        data: {
            'fromCurency': fromCurency,
            'toCurency': toCurency,
            'fromAmount': fromAmount
        },
        success: function (toAmount) {
            document.getElementById("toAmount").value = toAmount;
        }
    });
    
}