$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'title', "width": "15%" },
            { data: 'author', "width": "15%" },
            { data: 'isbn', "width": "15%" },
            { data: 'price', "width": "5%" },
            { data: 'category.name', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="btn-group" role="group"><a class="btn btn-success" href="/admin/product/upsert?id=${data}">Edit</a><a class="btn btn-danger" href="/admin/product/delete?id=${data}">Delete</a></div>`;
                },
                "width": "10%"
            }
            
            
        ]
    });
}

