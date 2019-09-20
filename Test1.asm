# QtSPIM Installation Check Program 1
.text
main: li $t0,23			#Loads 23 into the regeristry t0
li $t1,35			#Loads 35 into the regeristry t1	
li $t2,47			#Loads 47 into the regeristry t2
mul $t3,$t0,$t1			#Mutiplys t0(23) by t1(35) into regeristry t3 
mul $t3,$t3,$t2			#Mutiplys t3(805) by t2(47) into regeristry t3	
move $a0,$t3			#Moves t3(37835) into a0
li $v0,1			#Prints the int
syscall				#system call
li $v0,10			# terminate
syscall				#system call