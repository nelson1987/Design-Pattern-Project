using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProj.Tests
{
    public class Produto
    {
    }
    public class ProdutoController
    {
        public ProdutoController(IProdutoRepository produtoRepository)
        {
            ProdutoRepository = produtoRepository;
        }

        private IProdutoRepository ProdutoRepository { get; set; }
        public void Buscar()
        {
            ProdutoRepository.Buscar();
        }

    }

    public interface IProdutoRepository : IMongoDbRepository<Produto>, IDapperSqlDbRepository<Produto>
    {
    }

    public class ProdutoRepository : MongoDbRepository<Produto>
    {
    }

    public interface IMongoDbRepository<TEntity>
    {
        IQueryable<TEntity> Buscar();
    }

    public class MongoDbRepository<TEntity> : IMongoDbRepository<TEntity> where TEntity : class
    {
        public IQueryable<TEntity> Buscar()
        {
            throw new NotImplementedException();
        }
    }

    public interface IDapperSqlDbRepository<TEntity>
    {
        TEntity Inserir(TEntity entity);
    }

    public class DapperSqlDbRepository<TEntity> : IDapperSqlDbRepository<TEntity> where TEntity : class
    {
        public TEntity Inserir(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }

    public interface IEntityFrameworkSqlDbRepository<TEntity>
    {
        TEntity Inserir(TEntity entity);
    }

    public class EntityFrameworkSqlDbRepository<TEntity> : IEntityFrameworkSqlDbRepository<TEntity> where TEntity : class
    {
        public TEntity Inserir(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }

    public interface IXmlFileRepository<TEntity>
    {
        TEntity Ler(string linhaArquivo);

    }

    public class XmlFileRepository<TEntity> : IXmlFileRepository<TEntity> where TEntity : class
    {
        public TEntity Ler(string linhaArquivo)
        {
            throw new NotImplementedException();
        }
    }
}
