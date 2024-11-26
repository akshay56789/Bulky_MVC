$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#tblData2').DataTable({
        "ajax": { url: '/admin/company/getall' },
        "columns": [
            { data: 'name', "width": "15%" },
            { data: 'streetAddress', "width": "15%" },
            { data: 'city', "width": "15%" },
            { data: 'phoneNumber', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="btn-group" role="group"><a class="btn btn-success" href="/admin/company/upsert/${data}">Edit</a><a class="btn btn-danger" href="/admin/company/delete/${data}">Delete</a></div>`;
                },
                "width": "10%"
            }

        ]
    });
}


