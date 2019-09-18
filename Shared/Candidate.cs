using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPSValidation
{
    public class Candidate
    //: IEquatable<Candidate>
    {
        /// <summary> Address of this candidate </summary>
        public AddressKeyFormat AddressKeyFormat { get; set; }

        //public bool Equals(Candidate other)
        //{
        //    var add0 = this.AddressKeyFormat;
        //    var add1 = other.AddressKeyFormat;
        //    var add0Exist = add0.Address == null ? false : true;

        //    if (add0 == null || add1 == null) return false;
        //    if (!(add0.Address[0] ?? string.Empty).Equals(add1.Address[0] ?? string.Empty)) return false;
        //    if (!(add0.Address[1] ?? string.Empty).Equals(add1.Address[1] ?? string.Empty)) return false;
        //    if (!(add0.City ?? string.Empty).Equals(add1.City ?? string.Empty)) return false;
        //    if (!(add0.State ?? string.Empty).Equals(add1.State ?? string.Empty)) return false;
        //    if (!(add0.Zip ?? string.Empty).Equals(add1.Zip ?? string.Empty)) return false;
        //    if (!(add0.ZipExtension ?? string.Empty).Equals(add1.ZipExtension ?? string.Empty)) return false;
        //    return true;
        //}

        //public override int GetHashCode()
        //{
        //    var add0 = this.AddressKeyFormat;
        //    var hashAddress1 = add0.Address[0] == null ? 0 : add0.Address[0].GetHashCode();
        //    var hashAddress2 = add0.Address.Count == 1 ? 0 : add0.Address[1].GetHashCode();
        //    var hashCity = add0.City == null ? 0 : add0.City.GetHashCode();
        //    var hashState = add0.State == null ? 0 : add0.State.GetHashCode();
        //    var hashZip = add0.Zip == null ? 0 : add0.Zip.GetHashCode();
        //    var hashZipExtension = add0.ZipExtension == null ? 0 : add0.ZipExtension.GetHashCode();
        //    var hash = hashAddress2 ^ hashAddress1 ^ hashCity ^ hashState ^ hashZip ^ hashZipExtension * 17;
        //    return hash;
        //}

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}
    }
}
