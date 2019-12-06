'use strict';

(function () {
    Office.onReady()
        .then(
            // Checks for the DOM to load.
            $(document).ready(function () {
                // After the DOM is loaded, add-in-specific code can run.
                $('text').val("hahaha");
            })
    );
    //Office.onReady(function () {
    //    $(document).ready(function () {
    //        $('.ui.menu .ui.dropdown').dropdown({
    //            on: 'hover'
    //        });
    //        $('#exportExcel').click(exportEx);
    //    });

    //    function exportEx() {
    //        debugger;
    //        var settings = {
    //            "async": true,
    //            "crossDomain": true,
    //            "url": "https://localhost:44307/Product/ProductList",
    //            "method": "POST",
    //            "headers": {
    //                "cache-control": "no-cache",
    //            }
    //        }

    //        $.ajax(settings).done(function (response) {
    //            Excel.run(function (context) {
    //                var currentWorksheet = context.workbook.worksheets.getActiveWorksheet();
    //                var expensesTable = currentWorksheet.tables.add("A1:F1", true /*hasHeader*/);
    //                expensesTable.name = "Test";
    //                debugger;
    //                expensesTable.getHeaderRowRange().values =
    //                    [response[0]];
    //                response.shift();
    //                expensesTable.rows.add(null, response);

    //                expensesTable.getRange().format.autofitColumns();
    //                expensesTable.getRange().format.autofitRows();
    //                return context.sync();

    //            }).catch(function (error) {
    //                console.log("Error" + error);
    //                if (error instanceof OfficeExtension.Error) {
    //                    console.log("Debug info" + JSON.stringify(error.debugInfo));
    //                }
    //            });
    //        });
            
    //    }
    //});
})();