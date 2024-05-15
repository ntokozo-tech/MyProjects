<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Project.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link href="Bootsrap/bootstrap.min.css" rel="stylesheet" />
    <script src="Js/jquery-3.6.1.min.js"></script>


    <link href="https://cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css" rel="stylesheet" />
    <script src="SweetAlert/sweetalert2.all.min.js"></script>
    <title>Admin</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">


        </div>
     
                    <table id="mytable" class="table table-dark p-3">
                        <thead>
                            <tr>
                                <th scope="col">#</th>
                                <th scope="col">First</th>
                                <th scope="col">Last</th>
                                <th scope="col">Handle</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <th scope="row">1</th>
                                <td>Mark</td>
                                <td>Otto</td>
                                <td>@mdo</td>
                            </tr>
                            <tr>
                                <th scope="row">2</th>
                                <td>Jacob</td>
                                <td>Thornton</td>
                                <td>@fat</td>
                            </tr>
                            <tr>
                                <th scope="row">3</th>
                                <td>Larry</td>
                                <td>the Bird</td>
                                <td>@twitter</td>
                            </tr>
                        </tbody>
                    </table>
    </form>

    <script src="https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js"></script>
    <script src="Bootsrap/bootstrap.bundle.min.js"></script>
    <script>
        $(document).ready(function () {
            $('#mytable').DataTable();
            //Swal.fire(
            //    'The Internet?',
            //    'That thing is still around?',
            //    'question'
            //)
        });

    </script>

</body>
</html>
