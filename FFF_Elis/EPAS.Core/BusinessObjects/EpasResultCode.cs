﻿namespace EPAS.Core.BusinessObjects;

public enum EpasResultCode
{
    NoError = 0,
    InvalidApiKey = 1,
    InvalidFireBrigade = 2,
    CouldntAddOperation = 3,
    CouldntFindFirebrigade = 4,
    ProgramNotFound = 5,
    AlreadyExists = 6,
    CouldntFinishOperations = 7
}