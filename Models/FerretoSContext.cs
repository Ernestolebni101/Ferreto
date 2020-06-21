using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ferreto.Models
{
    public partial class FerretoSContext : DbContext
    {
        public FerretoSContext()
        {
        }

        public FerretoSContext(DbContextOptions<FerretoSContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Acceso> Acceso { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<Detallecompra> Detallecompra { get; set; }
        public virtual DbSet<Detallefactura> Detallefactura { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Movinventario> Movinventario { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Precioproducto> Precioproducto { get; set; }
        public virtual DbSet<Presentacion> Presentacion { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Rolacceso> Rolacceso { get; set; }
        public virtual DbSet<Rolusuario> Rolusuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-GOCGBT4\\SQLEXPRESS;Database=FerretoS;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acceso>(entity =>
            {
                entity.HasKey(e => e.Idacceso)
                    .HasName("PK__Acceso__F7B9EC7108DF438A");

                entity.Property(e => e.Idacceso).HasColumnName("idacceso");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Formulario)
                    .HasColumnName("formulario")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.Idcategoria)
                    .HasName("PK__Categori__140587C70FF55C1E");

                entity.Property(e => e.Idcategoria).HasColumnName("idcategoria");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => e.Idcompra)
                    .HasName("PK__Compra__81E11FE364F2179A");

                entity.Property(e => e.Idcompra).HasColumnName("idcompra");

                entity.Property(e => e.Codproveedor).HasColumnName("codproveedor")
                .HasMaxLength(15);

                entity.Property(e => e.Nombreusuario).HasColumnName("nombreusuario")
                .HasMaxLength(15);
                entity.Property(p => p.Nombreproveedor).HasColumnName("nombreproveedor");
                entity.Property(e => e.Fechacompra)
                    .HasColumnName("fechacompra")
                    .HasColumnType("date");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Totalcompra)
                    .HasColumnName("totalcompra")
                    .HasColumnType("decimal(18, 0)");
                entity.Property(e => e.Cantidad).HasColumnName("cantidad");
                entity.Property(e => e.Costounitario).HasColumnName("costounitario");
                entity.HasOne(d => d.CodproveedorNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.Codproveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_p");
                entity.HasOne(p => p.IdproductoNavigation)
                .WithMany(d => d.Compras).HasForeignKey(f => f.Idproducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tproducto");
                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.Idusuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_u");
            });

            modelBuilder.Entity<Detallecompra>(entity =>
            {
                entity.HasKey(e => e.Iddetalle)
                    .HasName("PK__Detallec__6FE8F71F8D9D731F");

                entity.Property(e => e.Iddetalle).HasColumnName("iddetalle");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Idcompra).HasColumnName("idcompra");

                entity.Property(e => e.Idproducto).HasColumnName("idproducto");

                entity.Property(e => e.Preciocompra).HasColumnName("preciocompra");

                entity.HasOne(d => d.IdcompraNavigation)
                    .WithMany(p => p.Detallecompra)
                    .HasForeignKey(d => d.Idcompra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_compra");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.Detallecompra)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_producto");
            });

            modelBuilder.Entity<Detallefactura>(entity =>
            {
                entity.HasKey(e => e.Iddetalle)
                    .HasName("PK__Venta__F82D1AFBC027FC2F");

                entity.Property(e => e.Iddetalle).HasColumnName("iddetalle");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Idproducto).HasColumnName("idproducto");

                entity.Property(e => e.Precioventa).HasColumnName("precioventa");

                entity.Property(e => e.Idfactura).HasColumnName("idfactura");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.Detallefactura)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pr");

                entity.HasOne(d => d.IdfacturaNavigation)
                 .WithMany(o => o.Detallefacturas)
                 .HasForeignKey(o => o.Idfactura)
                 .OnDelete(DeleteBehavior.ClientSetNull)
                 .HasConstraintName("fk_tfactura");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.Idfactura)
                    .HasName("PK__Factura__40FF55D87469121A");

                entity.Property(e => e.Idfactura).HasColumnName("idfactura");

                entity.Property(e => e.Fechafacturacion).HasColumnType("date");

                entity.Property(o => o.Nombreusuario).HasColumnType("nombreusuario");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Iva).HasColumnName("iva");

                entity.Property(e => e.Nserie)
                    .IsRequired()
                    .HasColumnName("nserie")
                    .HasMaxLength(15);

                entity.Property(e => e.Totalmasiva)
                    .HasColumnName("totalmasiva")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Totalsiniva)
                    .HasColumnName("totalsiniva")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.Factura)
                    .HasForeignKey(d => d.Idusuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Usua");

                //entity.HasOne(d => d.IdventaNavigation)
                //    .WithMany(p => p.Factura)
                //    .HasForeignKey(d => d.Idventa)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("fk_tventa");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.HasKey(e => e.Idinventario)
                    .HasName("PK__Inventar__4D2829C521F4387F");

                entity.Property(e => e.Idinventario).HasColumnName("idinventario");

                entity.Property(e => e.Existencia).HasColumnName("existencia");

                entity.Property(e => e.Idproducto).HasColumnName("idproducto");

                entity.Property(e => e.Nombreproducto)
                    .IsRequired()
                    .HasColumnName("nombreproducto")
                    .HasMaxLength(50);

                entity.Property(e => e.Unidademonetarias)
                    .HasColumnName("unidademonetarias")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.Inventario)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pro");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.Idmarca)
                    .HasName("PK__Marca__6D3757B2245E37C0");

                entity.Property(e => e.Idmarca).HasColumnName("idmarca");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Movinventario>(entity =>
            {
                entity.HasKey(e => e.Idmovinventario)
                    .HasName("PK__Movinven__0823AA9AD07451B9");

                entity.Property(e => e.Idmovinventario).HasColumnName("idmovinventario");

                entity.Property(e => e.Idinventario).HasColumnName("idinventario");

                entity.Property(e => e.Idproducto).HasColumnName("idproducto");

                entity.Property(e => e.Movimientonumero).HasColumnName("movimientonumero");

                entity.Property(e => e.Tipomovimiento).HasColumnName("tipomovimiento");

                entity.HasOne(d => d.IdinventarioNavigation)
                    .WithMany(p => p.Movinventario)
                    .HasForeignKey(d => d.Idinventario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tinventario");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.Movinventario)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tproductos");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.Idpersona)
                    .HasName("PK__Persona__5C5C1E2883604904");

                entity.Property(e => e.Idpersona).HasColumnName("idpersona");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasMaxLength(25);

                entity.Property(e => e.Cedula)
                    .HasColumnName("cedula")
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(20);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<Precioproducto>(entity =>
            {
                entity.HasKey(e => e.Idprecio)
                    .HasName("PK__Preciopr__7FFE066BD73D1BB6");

                entity.Property(e => e.Idprecio).HasColumnName("idprecio");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fechacreacion)
                    .HasColumnName("fechacreacion")
                    .HasColumnType("date");

                entity.Property(e => e.Idproducto).HasColumnName("idproducto");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.Precioproducto)
                    .HasForeignKey(d => d.Idproducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tproducts");
            });

            modelBuilder.Entity<Presentacion>(entity =>
            {
                entity.HasKey(e => e.Idpresentacion)
                    .HasName("PK__Presenta__FF41A0F79D5415C0");

                entity.Property(e => e.Idpresentacion).HasColumnName("idpresentacion");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200);
                entity.Property(e => e.Medida).HasColumnName("medida").HasMaxLength(10);
                entity.Property(e => e.Peso).HasMaxLength(15);

                entity.Property(e => e.Tamaño).HasMaxLength(15);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Idproducto)
                    .HasName("PK__Producto__DC53BE3C52DBC22F");

                entity.Property(e => e.Idproducto).HasColumnName("idproducto");

                entity.Property(e => e.Codproducto)
                    .IsRequired()
                    .HasColumnName("codproducto")
                    .HasMaxLength(100);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fecharegistro)
                    .HasColumnName("fecharegistro")
                    .HasColumnType("date");

                entity.Property(e => e.Fvencimiento)
                    .HasColumnName("fvencimiento")
                    .HasColumnType("date");

                entity.Property(e => e.Idcategoria).HasColumnName("idcategoria");

                entity.Property(e => e.Idmarca).HasColumnName("idmarca");

                entity.Property(e => e.Idpresentacion).HasColumnName("idpresentacion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.Ubicacion)
                    .HasColumnName("ubicacion")
                    .HasMaxLength(15);

                entity.HasOne(d => d.IdcategoriaNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.Idcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_categoria");

                entity.HasOne(d => d.IdmarcaNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.Idmarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_marca");

                entity.HasOne(d => d.IdpresentacionNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.Idpresentacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_presentacion");
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.HasKey(e => e.Idproveedor)
                    .HasName("PK__Proveedo__2DCD485D425146B8");

                entity.Property(e => e.Idproveedor).HasColumnName("idproveedor");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasColumnName("empresa")
                    .HasMaxLength(50);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Idpersona).HasColumnName("idpersona");

                entity.HasOne(d => d.IdpersonaNavigation)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.Idpersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_person");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.Idrol)
                    .HasName("PK__Rol__24C6BB20881A1796");

                entity.Property(e => e.Idrol).HasColumnName("idrol");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Nombrerol)
                    .IsRequired()
                    .HasColumnName("nombrerol")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Rolacceso>(entity =>
            {
                entity.HasKey(e => e.Idrolacceso)
                    .HasName("PK__Rolacces__C6C1FA005A3C3313");

                entity.Property(e => e.Idrolacceso).HasColumnName("idrolacceso");

                entity.Property(e => e.Idacceso).HasColumnName("idacceso");

                entity.Property(e => e.Idrol).HasColumnName("idrol");

                entity.HasOne(d => d.IdaccesoNavigation)
                    .WithMany(p => p.Rolacceso)
                    .HasForeignKey(d => d.Idacceso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Acceso");

                entity.HasOne(d => d.IdrolNavigation)
                    .WithMany(p => p.Rolacceso)
                    .HasForeignKey(d => d.Idrol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tRol");
            });

            modelBuilder.Entity<Rolusuario>(entity =>
            {
                entity.HasKey(e => e.Idrolusuario)
                    .HasName("PK__Rolusuar__72B1041BD51414B6");

                entity.Property(e => e.Idrolusuario).HasColumnName("idrolusuario");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Idrol).HasColumnName("idrol");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.HasOne(d => d.IdrolNavigation)
                    .WithMany(p => p.Rolusuario)
                    .HasForeignKey(d => d.Idrol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rol");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.Rolusuario)
                    .HasForeignKey(d => d.Idusuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tusuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Idusuario)
                    .HasName("PK__Usuario__080A97438E4C1E6C");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Idpersona).HasColumnName("idpersona");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(15);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdpersonaNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.Idpersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pers");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
