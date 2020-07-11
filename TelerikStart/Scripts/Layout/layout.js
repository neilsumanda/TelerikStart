
function rptMasterSearch(arg) {
    var searchFilter = $('.k-grid-search .k-input').val();
    console.log("searchFilter", searchFilter);

    if (searchFilter.length > 0) {
        $('.k-grid-search .k-input-icon .k-icon')
            .removeClass('k-i-search')
            .addClass('k-i-x')
            .css("cursor", "pointer");
    }
    else {
        $('.k-grid-search .k-input-icon .k-icon')
            .removeClass('k-i-x')
            .addClass('k-i-search');
    }
}

var close = $('.k-grid-search .k-input-icon .k-icon .k-i-x');
close.click(function () {
    var searchFilter = $('.k-grid-search .k-input').val();
    searchFilter.val('');


    console.log("asdfsdf");
     this.removeClass('k-i-x')
        .addClass('k-i-search');
    
    var str = "";
    var grid = $('#gridContactName').data('kendoGrid');

    $('.k-grid-search .k-input').val(str);
    grid.dataSource.filter({});

    //var grid2 = $('#gridTabStrip2').data("kendoGrid");
    //grid2.dataSource.read({ selectedKeys: "", calculatedValue:""});
});