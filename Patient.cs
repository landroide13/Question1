using System;

namespace Question1
{
  class Patient
  {
    private string patientID;
    private string name;
    private string checkInDate;
    private string assignedPersonal;

    public Patient(string id, string namePatient, string checkin, string ap )
    {
      this.patientID = id;
      this.name = namePatient;
      this.checkInDate = checkin;
      this.assignedPersonal = ap;
    }

    public string getPatientID()
    {
      return patientID;
    }
    public void setPatientID(string newPatId)
    {
      patientID = newPatId;
    }
    public string getName()
    {
      return name;
    }
    public void setName(string newName)
    {
      name = newName;
    }
    public string getCheckIn()
    {
      return checkInDate;
    }
    public void setCheckIn(string newCheckIn)
    {
      checkInDate = newCheckIn;
    }
    public string getAssignedPersonal()
    {
      return assignedPersonal;
    }
    public void setAssignedPersonal(string newAP)
    {
      assignedPersonal = newAP;
    }

  }


}



