using FluentValidator;
using FluentValidator.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class UpdateTodoCommand : Notifiable, ICommand
    {

        public UpdateTodoCommand()
        {

        }
        public UpdateTodoCommand(Guid id, string title, string user)
        {
            Id = id;
            Title = title;
            User = user;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }

        public string User { get; set; }
        public void Validate() => AddNotifications(new ValidationContract()
            .Requires()
            .HasMinLen(Title, 3, "Title", "Por favor, descreva melhor esta tarefa")
            .HasMinLen(User, 3, "User", "Usuário inválido")
            );
    }
}
