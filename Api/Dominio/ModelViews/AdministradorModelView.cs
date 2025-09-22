﻿using MinimalApi.Dominio.Enuns;

namespace MinimalApi.Dominio.ModelViews
{
    public record AdministradorModelView
    {
        public int Id { get; set; } = default!;
        public string Email { get; set; } = default!;
        public Perfil Perfil { get; set; } = default!;
    }
}
