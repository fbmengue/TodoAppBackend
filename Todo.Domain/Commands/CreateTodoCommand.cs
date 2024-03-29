﻿using System;
using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using FluentValidator;
using FluentValidator.Validation;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class CreateTodoCommand : Notifiable, ICommand
    {
        public CreateTodoCommand() { }

        public CreateTodoCommand(string title, string user, DateTime date)
        {
            Title = title;
            User = user;
            Date = date;
        }

        public string Title { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }

        public void Validate() => AddNotifications(new ValidationContract()
            .Requires()
            .HasMinLen(Title, 3, "Title", "Por favor, descreva melhor esta tarefa")
            .HasMinLen(User, 3, "User", "Usuário inválido"));


    }
}