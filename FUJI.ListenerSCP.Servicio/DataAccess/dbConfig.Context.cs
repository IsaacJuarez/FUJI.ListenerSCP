﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FUJI.ListenerSCP.Servicio.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbConfigEntities : DbContext
    {
        public dbConfigEntities()
            : base("name=dbConfigEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tbl_CAT_Modalidad> tbl_CAT_Modalidad { get; set; }
        public DbSet<tbl_CAT_TipoUsuario> tbl_CAT_TipoUsuario { get; set; }
        public DbSet<tbl_CAT_Usuarios> tbl_CAT_Usuarios { get; set; }
        public DbSet<tbl_ConfigSitio> tbl_ConfigSitio { get; set; }
        public DbSet<tbl_DET_Estudio> tbl_DET_Estudio { get; set; }
        public DbSet<tbl_DET_ServicioSitio> tbl_DET_ServicioSitio { get; set; }
        public DbSet<tbl_MST_Estudio> tbl_MST_Estudio { get; set; }
    }
}
