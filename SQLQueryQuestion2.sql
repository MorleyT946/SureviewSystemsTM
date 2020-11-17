SELECT CameraNumber, Name 
FROM DeviceCamera 
WHERE DeviceID = 1

SELECT DISTINCT DEVICE.DeviceID, DEVICE.IPAddress, DEVICE.Name
FROM Device [DEVICE] 
INNER JOIN DeviceCamera [CAM] ON DEVICE.DeviceID = CAM.DeviceID


SELECT DISTINCT DEVICE.DeviceID, DEVICE.IPAddress, DEVICE.Name
FROM Device [DEVICE] 
INNER JOIN DeviceCamera [CAM] ON DEVICE.DeviceID = CAM.DeviceID
WHERE DEVICE.CameraNumber LIKE “Front%”



--Assuming that the Camera Number is sequential even if cameras are 
--removed and added this would work. If the camera number was to change 
--for additional added this would fail

UPDATE DeviceCamera
SET Name = “Front Door Camera”
WHERE DeviceID = 1984 and CameraNumber = 2

