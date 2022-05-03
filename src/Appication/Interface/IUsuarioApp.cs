
using Core_Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;


namespace Interface.Appication
{
    public interface IUsuarioApp
    {
        Usuario Cadastro(Usuario usuario);

        Usuario Atualizacao(int id, Usuario usuario);
        Usuario BuscaPorId(int usuarioId);
        List<Usuario> Lista();
        bool Exclui(int usuarioId);

    }
}
