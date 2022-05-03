using Core_Domain.Interface;
using Core_Domain.Interface.Repository;
using Infra.Repository;
using Interface.Appication;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Appication
{
    public class UsuarioApp : IUsuarioApp
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioApp(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuario Cadastro(Usuario usuario)
        {
            usuario.Senha = Usuario.SHA256(usuario.Senha);
            _usuarioRepository.Salvar(usuario);

            return usuario;
        }

        public Usuario Atualizacao(int id, Usuario usuario)
        {
            Usuario useAtualiza = _usuarioRepository.GetById(id);

            useAtualiza.Nome = usuario.Nome;
            useAtualiza.Senha = usuario.Senha;
            useAtualiza.Email = usuario.Email;
            useAtualiza.Status = usuario.Status;

            _usuarioRepository.Atualizar(useAtualiza);

            return useAtualiza;
        }

        public Usuario BuscaPorId(int usuarioId)
        {

            return _usuarioRepository.GetById(usuarioId);
        }

        public List<Usuario> Lista()
        {

            return _usuarioRepository.GetAll().ToList();
        }

        public bool Exclui(int usuarioId)
        {
            try
            {
                Usuario usuario = _usuarioRepository.GetById(usuarioId);

                if (usuario == null)
                    return false;

                _usuarioRepository.Deletar(usuarioId);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
