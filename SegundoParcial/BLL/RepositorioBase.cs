﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SegundoParcial.DAL;
using SegundoParcial.Entidades;

namespace SegundoParcial.BLL
{
    public class RepositorioBase<T> : IDisposable, IRepository<T> where T : class
    {
        internal Contexto _contexto;


        public RepositorioBase()
        {
            _contexto = new Contexto();
        }

        public virtual bool Guardar(T entity)
        {
            bool paso = false;
            try
            {
                if (_contexto.Set<T>().Add(entity) != null)
                    paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public bool Modificar(T entity)
        {
            bool paso = false;

            try
            {
                _contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        internal bool Guardar(MetasDetalle tipo)
        {
            throw new NotImplementedException();
        }

        public T Buscar(int id)
        {
            T entity;
            try
            {
                entity = _contexto.Set<T>().Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return entity;
        }

        public bool Eliminar(int id)
        {
            bool paso = false;

            try
            {
                T entity = _contexto.Set<T>().Find(id);
                _contexto.Set<T>().Remove(entity);

                paso = _contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
            List<T> Lista = new List<T>();
            try
            {
                Lista = _contexto.Set<T>().Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }


        public static List<Vendedores> GetList(Expression<Func<Vendedores, bool>> persona)
        {
            List<Vendedores> Lista = new List<Vendedores>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Vendedores.Where(persona).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }


    }
}
