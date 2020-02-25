using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RiserAPI.Models.Gear;
using RiserAPI.Models.Jump;
using RiserAPI.Models.Link.Jump;
using RiserAPI.Models.Link.User;

namespace RiserAPI.Models.User
{
    public class User : Base
    {
        public User()
        {
            Guid = Guid.NewGuid();
        }
        //Use INT32 because GUID is not directly supported by some DBMSs

        public Guid Guid { get; set; }
        
        [Display(Name="Name")]
        [DataType(DataType.Text)]
        [StringLength(30, ErrorMessage = "Name can not be longer than 30 characters.")]
        [Required(ErrorMessage = "Name field is required.")]
        public string Name { get; set; }
        
        [Display(Name="Surname")]
        [DataType(DataType.Text)]
        [StringLength(30, ErrorMessage = "Surname can not be longer than 30 characters.")]
        [Required(ErrorMessage = "Surname field is required.")]
        public string Surname { get; set; }
        
        [Display(Name="Email")]
        [Required(ErrorMessage = "Email address is required.")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        public string Email { get; set; }
        public string Hash { get; set; }
        public string Token { get; set; }
        public string Salt { get; set; }
        
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Dob { get; set; }
        
        #region navigational properties.
        //User Profile Image
        public int ImageId { get; set; }
        public Image Image { get; set; }
        //LicenseType
        public int LicenseTypeId { get; set; }
        public LicenseType LicenseType { get; set; }
        //Settings
        public int SettingId { get; set; }
        public Setting Setting { get; set; }
        //Jumps
        public IEnumerable<Jump.Jump> Jumps { get; set; }
        //Comments
        public IEnumerable<Comment> Comments { get; set; }
        //Jump Participants
        public IEnumerable<JumpParticipant> JumpParticipants { get; set; }
        //Person Gear
        public IEnumerable<GearItem> GearItems { get; set; }
        //Sign Off Requests.
        public IEnumerable<SignOffRequest> SignOffRequests { get; set; }
        public SignOffRequest SignOffRequest { get; set; }
        //Images
        public IEnumerable<UserImage> Images { get; set; }
        //User Gear Items
        public IEnumerable<UserGear> UserGearItems { get; set; }
        #endregion

    }
}
