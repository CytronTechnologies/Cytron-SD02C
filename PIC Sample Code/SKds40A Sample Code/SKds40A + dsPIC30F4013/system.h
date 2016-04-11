/*******************************************************************************
* This is the header file that describes the system properties.
* SKds40A  + dsPIC30F4013, dsPIC30F3014 should be compatible
* Author: Kong Wai Weng @ Cytron Technologies Sdn. Bhd.
*******************************************************************************/



// Oscillator Frequency.
#define	_XTAL_FREQ			80000000			//80 MHz, uses 10MHz crystal, config 8xPLL

// Default UART baud rate.
#define UART_BAUD			9600

// I/O Connections.
#define LED1				LATDbits.LATD2			// 3014 & 4013
#define LED2				LATDbits.LATD3			// 3014 & 4013

#define SW1					PORTAbits.RA11			// 3014 & 4013
#define SW2					PORTDbits.RD8			// 3014 & 4013

#define BUZZER 				LATFbits.LATF6			// for test board, the buzzer at RF6

// Parallel 2x16 Character LCD
#define LCD_RS			PORTFbits.RF0		// RS pin is used for LCD to differentiate data is command or character, RF0
#define LCD_E			PORTFbits.RF1		// E clock pin is connected to RF1	

#define	LCD_DATA		PORTB	// Data port of LCD is connected to PORTB, 8 bit mode
								// DB7(LCD) = RB7(dsPIC)
								// DB6(LCD) = RB6(dsPIC)
								// DB5(LCD) = RB5(dsPIC)
								// DB4(LCD) = RB4(dsPIC)
								// DB3(LCD) = RB3(dsPIC)
								// DB2(LCD) = RB2(dsPIC)
								// DB1(LCD) = RB1(dsPIC)
								// DB0(LCD) = RB0(dsPIC)
