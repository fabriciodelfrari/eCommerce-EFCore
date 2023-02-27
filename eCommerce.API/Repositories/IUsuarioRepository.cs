﻿using eCommerce.Models;
using eCommerce.Models.Enum;

namespace eCommerce.API.Repositories
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetById(int id);
        Task<ICollection<Usuario>> GetAll();
        Task<ICollection<Usuario>> GetBySituacaoCadastral(SituacaoCadastral situacao);
        Usuario Add(Usuario usuario);
        Task<Usuario> Update(Usuario usuario);
        bool Delete(int id);
        Task<Usuario> AddEndereco(EnderecoEntrega enderecoEntrega);
        Task<Usuario> RemoveEndereco(EnderecoEntrega enderecoEntrega);
        Task<Usuario> UpdateEndereco(EnderecoEntrega enderecoEntrega);

    }
}
