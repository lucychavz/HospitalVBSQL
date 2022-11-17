Imports Domain

Public Class FormUsers

    Private userModel As UserModel = New UserModel()
    Private userList As List(Of UserModel)

    Public Sub New()
        InitializeComponent()
        ListUsers()
    End Sub

    Private Sub ListUsers()
        'LLenar la cuadricula de datos con la lista de usuarios.
        userList = userModel.GetAllUsers().ToList() 'Obtener todos los usuarios.
        dataGridView1.DataSource = userList 'Establecer la fuente de datos.
    End Sub

    Private Sub FormUsers_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        'Agregar nuevo usuario.
        Dim userForm = New FormUserMaintenance() 'Instanciar formulario de mantenimiento sin parametros.
        Dim result As DialogResult = userForm.ShowDialog() 'Mostrar formulario como ventana de dialogo y guardar resultado.

        If result = System.Windows.Forms.DialogResult.OK Then 'Si el resultado de dialogo es OK, actualizar vista de datos.
            ListUsers()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        'Editar usuario.

        If dataGridView1.RowCount <= 0 Then
            MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If dataGridView1.SelectedCells.Count > 1 Then
            Dim userDM = userModel.GetUserById(CInt(dataGridView1.CurrentRow.Cells(0).Value)) 'Obtener ID del usuario y buscar usando el método GetUser(id).

            If userDM IsNot Nothing Then
                Dim userForm = New FormUserMaintenance(userDM, False) 'Instanciar formulario de mantenimiento y enviar parametros necesarios (modelo de usuario - NO es actualizar datos de perfil de usuario)
                Dim result As DialogResult = userForm.ShowDialog() 'Mostrar formulario como ventana de dialogo y guardar resultado.

                If result = System.Windows.Forms.DialogResult.OK Then 'Si el resultado de dialogo es OK, actualizar vista de datos.
                    ListUsers()
                End If
            Else
                MessageBox.Show("No se ha encontrado usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemove.Click
        'Eliminar usuario.

        If dataGridView1.RowCount <= 0 Then
            MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If dataGridView1.SelectedCells.Count > 1 Then
            Dim result = userModel.RemoveUser(CInt(dataGridView1.CurrentRow.Cells(0).Value)) 'Obtener ID del usuario e invocar el metodo eliminar usuario del modelo.

            If result > 0 Then
                MessageBox.Show("Usuario eliminado con éxito")
                ListUsers()
            Else
                MessageBox.Show("No se ha realizado operación, intente nuevamente")
            End If
        Else
            MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class