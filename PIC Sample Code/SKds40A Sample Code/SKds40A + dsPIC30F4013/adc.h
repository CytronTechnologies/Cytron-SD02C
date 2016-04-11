/*******************************************************************************
* This file provides the functions for the ADC module.
*
* Author: Kong Wai Weng @ Cytron Technologies Sdn. Bhd.
*******************************************************************************/



#ifndef _ADC_H
#define _ADC_H



/*******************************************************************************
* PUBLIC FUNCTION PROTOTYPES                                                   *
*******************************************************************************/

/*******************************************************************************
* PUBLIC FUNCTION: adc_initialize
*
* PARAMETERS:
* ~ void
*
* RETURN:
* ~ void
*
* DESCRIPTIONS:
* Initialize the ADC module.
*
*******************************************************************************/
extern void adc_initialize(void);



/*******************************************************************************
* PUBLIC FUNCTION: ui_get_supply_voltage
*
* PARAMETERS:
* ~ void
*
* RETURN:
* ~ The supply voltage in mV.
*
* DESCRIPTIONS:
* Get the supply voltage in mV.
*
*******************************************************************************/
extern unsigned int ui_get_supply_voltage(void);



/*******************************************************************************
* PUBLIC FUNCTION: ui_get_current
*
* PARAMETERS:
* ~ void
*
* RETURN:
* ~ The motor current in mA.
*
* DESCRIPTIONS:
* Get the motor current in mA.
*
*******************************************************************************/
extern unsigned int ui_get_current(void);



/*******************************************************************************
* PUBLIC FUNCTION: ui_get_speed_input
*
* PARAMETERS:
* ~ void
*
* RETURN:
* ~ The speed input in rpm.
*
* DESCRIPTIONS:
* Get the speed input in rpm.
*
*******************************************************************************/
extern unsigned int ui_get_speed_input(void);



#endif
