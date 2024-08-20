﻿
using EAI_Concept.Interfaces.Instructions.Factories;

namespace EAI_Concept.Interfaces.Instructions.Commands.Querycommands
{
    public abstract class BaseQueryCommandResult(bool isSuccess) : BaseInstructionCommandResult(isSuccess) { }

    public abstract class QueryCommandHolder<TResult>(QueryInstruction instruction)
        : BaseInstructionCommand<QueryInstruction, TResult>(instruction)
        where TResult : BaseQueryCommandResult
    { }

}
