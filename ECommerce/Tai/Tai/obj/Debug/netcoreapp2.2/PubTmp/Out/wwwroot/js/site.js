// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
(function () {

    $("#cart").on("click", function () {
        debugger;
        $(".shopping-cart").fadeToggle("fast");
    });
    
})();
function AddToCart(product, qty = 1) {
    var data = {
        "Product": {
            "ProductId": product
        },
        "Quantity": qty
    };
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            location.reload();
        }
    };
    xhttp.open("POST", "/Cart/AddToCart");
    xhttp.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    xhttp.send(JSON.stringify(data));
}