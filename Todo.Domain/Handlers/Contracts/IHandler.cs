using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Input;
using Todo.Domain.Commands.Contracts;
using ICommand = Todo.Domain.Commands.Contracts.ICommand;

namespace Todo.Domain.Handlers
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
