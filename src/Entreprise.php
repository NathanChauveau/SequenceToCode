<?php

namespace Carfleet;

class Entreprise
{
    #region private attributes
    private array $vehicules = [];
    private array $drivers = [];
    #endregion private attributes

    private function getVehiculeByChassisNumber(string $chassisNumber): Vehicule
    {
        foreach ($this->vehicules as $vehicule) {
            if ($vehicule->chassisNumber === $chassisNumber) {
                return $vehicule;
            }
        }
        throw new VehicleNotFoundException();
    }

    private function getDriverByEmailAddress(string $driverEmailAddress): Driver
    {
        foreach ($this->drivers as $driver) {
            if ($driver->emailAddress === $driverEmailAddress) {
                return $driver;
            }
        }
        throw new DriverNotFoundException();
    }

    public function assignVehiculeToDriver(string $chassisNumber, string $driverEmailAddress): void
    {
        $driver = $this->getDriverByEmailAddress($driverEmailAddress);
        $vehicule = $this->getVehiculeByChassisNumber($chassisNumber);
        
        // Logic to assign the vehicle to the driver goes here
    }

    #region nested classes
    class EnterpriseException extends Exception {}

    class VehicleNotFoundException extends EnterpriseException {}

    class DriverNotFoundException extends EnterpriseException {}
    #endregion nested classes
}


/*
class Vehicule
{
    public string $chassisNumber;

    public function __construct(string $chassisNumber)
    {
        $this->chassisNumber = $chassisNumber;
    }
}

class Driver
{
    public string $emailAddress;

    public function __construct(string $emailAddress)
    {
        $this->emailAddress = $emailAddress;
    }
} décalé dans les autres classes*/
