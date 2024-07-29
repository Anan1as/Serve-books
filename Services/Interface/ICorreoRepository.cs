using Serve_books.DTOs;

namespace Serve_books.Services.Interface
{
	public interface ICorreoRepository
	{
		public void SendEmail(CorreoDTO correoDTO);

		public string CorreoRegistro(string CorreoUsuario);

		public string CorreoInicio(string CorreoUsuario, string ip);

		public string CorreoSolicitudPrestamo(string CorreoUsuario, string NombreLibro);

		public string CorreoAutorizcionPrestamo(string CorreoUsuario, string NombreLibro);

	}
}
