<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="ProyectoFinalInventario2022.Login.register" %>


<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="utf-8">
	<meta name="author" content="Kodinger">
	<meta name="viewport" content="width=device-width,initial-scale=1">
	<title>My Login Page &mdash; Bootstrap 4 Login Page Snippet</title>
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
	<link rel="stylesheet" type="text/css" href="/css/my-login.css">
</head>
<body class="my-login-page">
	<form id="form1" runat="server">
	<section class="h-100">
		<div class="container h-100">
			<div class="row justify-content-md-center h-100">
				<div class="card-wrapper">
					<div class="brand">
						<img src="/img/computadora.png" alt="logo">
					</div>
					<div class="card fat">
						<div class="card-body">
							<h4 class="card-title">Register</h4>
								<div class="form-group">
									<label for="name">Nombre</label>
									<input id="name" type="text" runat="server" class="form-control" name="name" required autofocus>
									<div class="invalid-feedback">
										Cual es tu nombre?
									</div>
								</div>

								<div class="form-group">
									<label for="email">Correo electronico</label>
									<input id="email" type="email" runat="server" class="form-control" name="email" required>
									<div class="invalid-feedback">
										Tu correo electronico es invalido
									</div>
								</div>

								<div class="form-group">
									<label for="password">Contraseña</label>
									<input id="password" type="password" runat="server" class="form-control" name="password" required>
									<div class="invalid-feedback">
										La contraseña es requerida
									</div>
								</div>

								<div class="form-group">
									<div class="custom-checkbox custom-control">
										<input type="checkbox" name="agree" id="agree" class="custom-control-input" required="">
										<label for="agree" class="custom-control-label">Acepto los <a href="#">Terminos y condiciones</a></label>
										<div class="invalid-feedback">
											Lee terminos y condiciones
										</div>
									</div>
								</div>

								<div class="form-group m-0">
									<button type="submit" id="uibtnCrearUsuario" runat="server" onserverclick="uibtnCrearUsuario_Click" class="btn btn-primary btn-block">
										Registrar
									</button>
								</div>
								<div class="mt-4 text-center">
									Ya posees una cuenta? <a href="Login.aspx">Login</a>
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
								</div>
						</div>
					</div>
					<div class="footer">
						Copyright 2022; Social Media
					</div>
				</div>
			</div>
		</div>
	</section>
	<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
	<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
	<script src="/js/my-login.js"></script>
    </form>
</body>
</html>