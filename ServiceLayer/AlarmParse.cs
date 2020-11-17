using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ServiceLayer
{
    public class AlarmParse
    {
        public bool CorrectMessage { private set; get; }
        public string ReturnMessage { private set; get; }
        public int? ServerNumber { private set; get; }
        public int? AlarmId { private set; get; }


        public AlarmParse()
        {
            CorrectMessage = false;
            ServerNumber = null;
            AlarmId = null;
        }

        public static AlarmParse ParseMessage(string message)
        {
            try { 
                AlarmParse returnObject = new AlarmParse();

                message = Regex.Replace(message, @"[^\w\s\-]", "");

                List<string> words = message.ToUpper().Split().ToList();

                int wordsCount = 0;
                int? alarmId = null;
                int alarmIdParse = 0;
                bool alarmIdTextFound = false;
                int? serverNumber = null;
                int serverNumberParse = 0;

                while(wordsCount < words.Count)
                {
                    //find alarm ID
                    if (words[wordsCount].Equals("ALARM"))
                    {
                        wordsCount += 1;
                        if (wordsCount > words.Count - 1)
                        {
                            break;
                        }
                        if (words[wordsCount].Equals("ID"))
                        {
                            wordsCount += 1;
                            alarmIdTextFound = true;
                            if (int.TryParse(words[wordsCount], out alarmIdParse)) {
                                alarmId = alarmIdParse;
                            }
                        }
                    }

                    //Find Server number and alarm ID depending on structure
                    if (words[wordsCount].Equals("SERVER"))
                    {
                        wordsCount += 1;
                        if (words[wordsCount].Equals("NUMBER") && wordsCount < words.Count)
                        {
                            wordsCount += 1;
                            if(wordsCount > words.Count - 1)
                            {
                                break;
                            }

                            if (int.TryParse(words[wordsCount], out serverNumberParse))
                            {
                                serverNumber = serverNumberParse;
                                if(alarmIdTextFound == true && alarmId == null)
                                {
                                    wordsCount += 1;
                                    if (wordsCount > words.Count - 1)
                                    {
                                        break;
                                    }
                                    if (words[wordsCount].Equals("IS"))
                                    {
                                        wordsCount += 1;
                                        if (wordsCount > words.Count - 1)
                                        {
                                            break;
                                        }
                                        if (int.TryParse(words[wordsCount], out alarmIdParse)) {
                                            alarmId = alarmIdParse;
                                            //escape loop as values have been found 
                                            break;
                                        }
                                    } else
                                    {
                                        //if the word "is" not found after the server number then escape loop
                                        break;
                                    }
                                } else
                                {
                                    break; //escape loop as values have been found
                                }
                            }
                            else
                            {
                                break; //if server number not found after the words server number then escape loop
                            }
                        }
                    }

                    wordsCount += 1;
                }



                if (alarmId == null && serverNumber == null)
                {
                    returnObject.CorrectMessage = false;
                    returnObject.ReturnMessage = "No vaules have been detected";
                }
                else if (alarmId != null && serverNumber == null)
                {
                    returnObject.CorrectMessage = false;
                    returnObject.ReturnMessage = "Only alarm Id has been found";
                }
                else if (alarmId == null && serverNumber != null)
                {
                    returnObject.CorrectMessage = false;
                    returnObject.ReturnMessage = "Only Server Number has been found";
                }
                else
                {
                    returnObject.CorrectMessage = true;
                    returnObject.ReturnMessage = "Alarm and server number has been identified";
                }

                returnObject.AlarmId = alarmId;
                returnObject.ServerNumber = serverNumber;

                return returnObject;

            }

            catch (Exception ex)
            {
                return new AlarmParse()
                {
                    CorrectMessage = false,
                    ReturnMessage = "Error detected: " + ex.InnerException
                };

            }
        }


    }
}
