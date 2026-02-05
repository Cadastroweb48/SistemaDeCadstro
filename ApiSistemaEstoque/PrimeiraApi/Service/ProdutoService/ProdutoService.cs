using Microsoft.EntityFrameworkCore;
using PrimeiraApi.DTOs.ProdutoDto;
using PrimeiraApi.Models;
using PrimeiraApi.Repositories;

namespace PrimeiraApi.Service.ProdutoService
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepositorio _repo;

        public ProdutoService(IProdutoRepositorio repo)
        {
            _repo = repo;
        }

		

        public async Task<List<ProdutoReandDto>> GetAll()
        {

            var produtos = await _repo.GetAll();

            return produtos.Select(p => new ProdutoReandDto
            {
				Pd_Nome = p.Pd_Nome,
				Pd_Quantidade = p.Pd_Quantidade,
				Pd_Descricao = p.Pd_Descricao,
				Pd_ImagenUrl = p.Pd_ImagenUrl,
				Pd_Preco = p.Pd_Preco,
		        CategoriaId = p.CategoriaId,
				CategoriaNome = p.Categoria.Cat_Nome,
				DataCadastro = p.DataCadastro,



			}).ToList();
		}

		public async Task<ProdutoReandDto?> GetById(int id)
		{
			var produto = await _repo.GetById(id);

			if (produto == null)
				return null;

			return new ProdutoReandDto
			{
				Id = produto.Pd_Id,
				Nome = produto.Pd_Nome,
				Quantidade = produto.Pd_Quantidade,

				
			};
		}
		public async Task Create(ProdutoCreateDto dto)
        {
			if (string.IsNullOrWhiteSpace(dto.Nome))
				throw new Exception("Nome é obrigatório");

			if (dto.Quantidade < 0)
				throw new Exception("Quantidade não pode ser negativa");

			var produto =  new Produto {

			   Pd_Nome = dto.Nome,
               Pd_Quantidade = dto.Quantidade,
			 

			};
			await _repo.Add(produto);
		}

		public async Task Update(int id, ProdutoCreateDto dto)
		{
			var produto = await _repo.GetById(id);
			if (produto == null)
				throw new Exception("Produto não encontrado");

			produto.Pd_Nome = dto.Nome;
			produto.Pd_Quantidade = dto.Quantidade;
			
			await _repo.Update(produto);
		}



		public async Task Delete(int id)
		{
			var produto = await _repo.GetById(id);
			if (produto == null)
				throw new Exception("Produto não encontrado");

			// REGRA DE NEGÓCIO
			if (produto.Pd_Quantidade > 0)
				throw new Exception("Não é possível excluir produto com estoque");

			await _repo.Delete(produto);
		}


	}
}
