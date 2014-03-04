Parr 30 C# Implmentation
========================

What is PARR 30?
----------------

The Parr 30 is an algorithm, created by the [Nuffield Trust](http://www.nuffieldtrust.org.uk/), to predict hospital readmission:

> Following the Government’s announcement in 2010 that hospitals in England would not be reimbursed for some emergency hospital readmissions occurring 
> within 30 days of discharge, the interest in finding ways of preventing these became greater than ever. The Nuffield Trust developed an algorithm for 
> predicting which patients are most at risk of short term readmission, designed to be used by acute hospitals.

The algorithm has three basic categories:

* General information about the patient
* Information about the patient’s history of emergency admissions
* Information about the patient medical history

More information can found by clicking on the below links:

* http://www.nuffieldtrust.org.uk/how-implement-parr-30-model-required-data-and-algorithm
* http://www.nuffieldtrust.org.uk/how-implement-parr-30-model-required-data-and-algorithm

About the Implementation
------------------------

The way PARR 30 scores the likelihood of hospital readmission by using the following criteria:

* The hospital in which the patient was treated
* The patient's age
* The deprivation score of the lower super output area (LSOA) in which the patient resides (according to the 2007 census)
* The number of hospital admissions in the last year
* Whether or not the patient was admitted to hospital in the last month
* Whether or not the current hospital admission was for an emergency
* Information about the patient's medical history, and specifically whether or not they suffer from the following conditions:
    * Congestive heart failure
    * Peripheral vascular disease
    * Dementia
    * Chronic pulmonary disease
    * Other liver disease
    * Other malignant cancer
    * Metastatic cancer with solid tumour
    * Moderate/severe liver disease
    * Diabetes with chronic complications
    * Hemiplegia or paraplegia
    * Renal disease