(function () {
    'use strict';
    Office.initialize = function (reason) {
        $(document).ready(function () {

            
            $('#exportExcel').click(function () {
                loadSampleData();
            });
        });
    };
    function loadSampleData() {
        var kitu = Math.floor(Math.random() * Math.floor(99));
        var cbval = $('#sl').val();
        if (cbval === 'date') {
            var date = $('#datepicker').val();
            $.ajax({
                url: "/Excel/SaleStatistical",
                type: "POST",
                dataType: 'json',
                data: {
                    CommandAction: {
                        SaleDate: date
                    }
                },
                success: function (data) {

                    debugger;
                    // Run a batch operation against the Excel object model
                    Excel.run(function (context) {
                        var currentWorksheet = context.workbook.worksheets.getActiveWorksheet();
                        var expensesTable = currentWorksheet.tables.add("A1:G1", true /*hasHeader*/);
                        expensesTable.name = "ngay" + kitu;
                        debugger;
                        expensesTable.getHeaderRowRange().values =
                            [data[0]];
                        data.shift();
                        expensesTable.rows.add(null, data);

                        expensesTable.getRange().format.autofitColumns();
                        expensesTable.getRange().format.autofitRows();
                        return context.sync();

                    }).catch(function (error) {
                        console.log("Error" + error);
                        if (error instanceof OfficeExtension.Error) {
                            console.log("Debug info" + JSON.stringify(error.debugInfo));
                        }
                    });
                }
            });
        }
        else {
            status = $('#sta').val();
            debugger;
            $.ajax({
                url: "/Excel/SaleStatisticalByStatus",
                type: "POST",
                dataType: 'json',
                data: {
                    CommandAction: {
                        Status: status
                    }
                },
                success: function (data) {
                    
                    debugger;
                    // Run a batch operation against the Excel object model
                    Excel.run(function (context) {
                        var currentWorksheet = context.workbook.worksheets.getActiveWorksheet();
                        var expensesTable = currentWorksheet.tables.add("A1:G1", true /*hasHeader*/);
                        expensesTable.name = "trangthai" + kitu;
                        debugger;
                        expensesTable.getHeaderRowRange().values =
                            [data[0]];
                        data.shift();
                        expensesTable.rows.add(null, data);

                        expensesTable.getRange().format.autofitColumns();
                        expensesTable.getRange().format.autofitRows();
                        return context.sync();

                    }).catch(function (error) {
                        console.log("Error" + error);
                        if (error instanceof OfficeExtension.Error) {
                            console.log("Debug info" + JSON.stringify(error.debugInfo));
                        }
                    });
                }
            });
        }
    }
})();