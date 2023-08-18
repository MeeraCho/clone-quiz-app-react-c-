using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAPI.Models
{
    public class Participant
	{
        [Key]
        public int MyParticipantId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Email { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Name { get; set; }
        public int Score { get; set; }
        public int TimeTaken { get; set; }
    }
}

