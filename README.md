<p align="center">
  <h3> ⚙️ Minimal Api </h3>  
</p>


Projeto desenvolvido em **.NET 9** utilizando **Minimal API**, focado em gerenciamento de veículos e administradores. O projeto utiliza **Entity Framework Core** com **MySQL** para persistência de dados e implementa **autenticação JWT** com controle de acesso por roles (Administrador e Editor).

---

<p align="center">
  <h3> 🧾 Funcionalidades </h3>  
</p>

- **Gerenciamento de Veículos**  
  - `GET /veiculos` → Lista todos os veículos (com paginação opcional)  
  - `GET /veiculos/{id}` → Busca veículo pelo ID  
  - `POST /veiculos` → Insere um novo veículo  
  - `PUT /veiculos/{id}` → Atualiza um veículo existente  
  - `DELETE /veiculos/{id}` → Remove um veículo  

- **Gerenciamento de Administradores**  
  - `GET /administradores` → Lista todos os administradores  
  - `GET /administradores/{id}` → Busca administrador pelo ID  
  - `POST /administradores` → Insere um novo administrador  
  - `POST /administradores/login` → Login com geração de token JWT  

- Validações de dados em DTOs (veículos e administradores)  
- Autenticação e autorização via JWT  
- Controle de acesso por roles: `Adm` e `Editor`  
- Suporte a CORS  
- Documentação automática via **Swagger**

---
<p align="center">
  <h3> 🔗 Tecnologias Utilizadas </h3>  
</p>

- .NET 9  
- Minimal API  
- Entity Framework Core  
- MySQL  
- JWT para autenticação  
- Swagger para documentação 
