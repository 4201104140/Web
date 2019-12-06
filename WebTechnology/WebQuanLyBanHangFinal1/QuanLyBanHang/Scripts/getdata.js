
function getProductList() {
    var settings = {
        "async": true,
        "crossDomain": true,
        "url": "https://localhost:44307/Product/ProductList",
        "method": "POST",
        "headers": {
            "cache-control": "no-cache",
        }
    }

    $.ajax(settings).done(function (response) {
        debugger;
        return response;
    });
    
};