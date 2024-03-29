﻿using MediatR;
using SportClub.Domain.Enum;

namespace SportClub.Application.CQRS.Competitor.Command;

public class AddCompetitorCommand : IRequest<Domain.Entity.Competitor>
{
    public DateTime? MedicalExaminationExpiryDate { get; set; }
    public bool IsPaid { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; } = null!;
    public Gender Gender { get; set; }
    public Degree? Degree { get; set; }
}